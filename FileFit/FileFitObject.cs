using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace FileFit
{
    enum AddOptions
    {
        Files = 1,
        Directories = 2,
        Both = 3,
    }

    class IMensurableSetComparer : IComparer<IMensurable[]>
    {
        public int Compare(IMensurable[] x, IMensurable[] y)
        {
            return (x.Sum(i => i.Size) - y.Sum(i => i.Size) <= 0) ? 1 : -1;
        }
    }

    abstract class IMensurable
    {
        public string Name { get; protected set; }
        public Int64 Size { get; protected set; }
        public string FullPath { get; protected set; }

        public static Int64 GetSize(IMensurable i)
        {
            return i.Size;
        }
    }

    class MensurableFile : IMensurable
    {
        public MensurableFile(string path, long cluster)
        {
            FileInfo i = new FileInfo(path);

            Name = i.Name;
            Size = ((i.Length + cluster - 1) / cluster) * cluster;
            FullPath = i.FullName;
        }
    }

    class MensurableDirectory : IMensurable
    {
        public MensurableDirectory(string path, long cluster)
        {
            DirectoryInfo i = new DirectoryInfo(path);

            FullPath = i.FullName;
            Name = i.Name;

            FileInfo[] files = i.GetFiles();

            DirectoryInfo[] directories = i.GetDirectories();

            foreach (FileInfo f in files)
                Size += new MensurableFile(f.FullName, cluster).Size;

            foreach (DirectoryInfo d in directories)
                Size += new MensurableDirectory(d.FullName, cluster).Size;
        }
    }

    class FileFitObject
    {
        public List<IMensurable> List = new List<IMensurable>();

        public void AddFile(string path, long cluster)
        {
            List.Add(new MensurableFile(path, cluster));
        }

        public void AddDirectory(string path, long cluster)
        {
            List.Add(new MensurableDirectory(path, cluster));
        }

        public void AddDirectoryItems(string path, long cluster, AddOptions options)
        {
            DirectoryInfo parent = new DirectoryInfo(path);

            if ((options == AddOptions.Files) || (options == AddOptions.Both))
            {
                foreach (var f in parent.GetFiles())
                {
                    AddFile(f.FullName, cluster);
                }
            }

            if ((options == AddOptions.Directories) || (options == AddOptions.Both))
            {
                foreach (var d in parent.GetDirectories())
                {
                    AddDirectory(d.FullName, cluster);
                }
            }
        }

        public void AddDirectoryItems(string path, long cluster)
        {
            AddDirectoryItems(path, cluster, AddOptions.Both);
        }

        public IMensurable[][] PowerSet()
        {
            Int64 sets = (1 << List.Count) - 1;

            IMensurable[][] ret = new IMensurable[sets][];

            for (Int64 i = 0; i < sets; i++)
            {
                List<IMensurable> set = new List<IMensurable>(List.Count);
                //ThreadPool.QueueUserWorkItem(new WaitCallback((o) => { }));
                for (int j = 0; j < List.Count; j++)
                    if (((i >> j) & 1) == 1)
                        set.Add(List[j]);

                ret[i] = set.ToArray();
            }

            return ret;
        }

        public IMensurable[][] TestRange(Int64 minSize, Int64 maxSize, bool sort)
        {
            List<IMensurable[]> ret = new List<IMensurable[]>();

            IMensurable[][] sets = PowerSet();

            foreach (IMensurable[] set in sets)
            {
                Int64 z = set.Sum(i => i.Size);

                if (z > maxSize || z < minSize)
                    continue;

                ret.Add(set);
            }

            ret.Sort(new IMensurableSetComparer());

            return ret.ToArray();
        }
    }
}
