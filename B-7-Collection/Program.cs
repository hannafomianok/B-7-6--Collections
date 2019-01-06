using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayListPoemSort();
            //ArrayListOfSongsSort();
            //GenericListOfSongsSort();
            //GenericListOfNeighborSearch();
            DictionaryOfNeighborSearch();

            Console.ReadLine();
        }

        public static void ArrayListPoemSort()
        {
            var poem = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                var line = Console.ReadLine();
                poem.Add(line);
            }

            Console.WriteLine();

            poem.RemoveAt(poem.Count - 1);

            object[] arr = poem.ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


        }


        public static void ArrayListOfSongsSort()
        {
            var poem = new ArrayList();

            for (int i = 0; i < 5; i++)
            {
                var song = new Song();
                song.Lirics = Console.ReadLine();
                poem.Add(song);
            }

            Console.WriteLine();

            poem.RemoveAt(poem.Count - 1);

            object[] arr = poem.ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }


        }

        public class Song
        {
            public string Lirics;// необходимо переопределить, т.к. выводит просто название класса
            public override string ToString()
            {
                return this.Lirics;
            }

        }

        public static void GenericListOfSongsSort()
        {
            List<Song> songs = new List<Song>();

            for (int i = 0; i < 5; i++)
            {
                songs.Add(new Song() { Lirics = Console.ReadLine() });
            }

            Console.WriteLine();

            foreach (Song s in songs)
            {
                Console.WriteLine(s.Lirics);
            }


        }

        public static void GenericListOfNeighborSearch()
        {
            List<Neighbor> floorNeighbors = new List<Neighbor>();
            floorNeighbors.Add(new Neighbor() { FullName = "Petrov", FlatNumber = 1, PhoneNumber = 7512548 });
            floorNeighbors.Add(new Neighbor() { FullName = "Sidorov", FlatNumber = 2, PhoneNumber = 4587963 });
            floorNeighbors.Add(new Neighbor() { FullName = "Kuzin", FlatNumber = 3, PhoneNumber = 7589638 });
            floorNeighbors.Add(new Neighbor() { FullName = "Fomenok", FlatNumber = 4, PhoneNumber = 4512645 });

            floorNeighbors.Remove(new Neighbor() { FullName = "Fomenok", FlatNumber = 4, PhoneNumber = 4512645 });

            var numberofFlat = int.Parse(Console.ReadLine());

            foreach (var flat in floorNeighbors)
            {
                if (numberofFlat == flat.FlatNumber)
                {
                    Console.WriteLine($"The neighor - {flat.FullName}, his/her number - {flat.PhoneNumber}");
                }
            }


        }

        public class Neighbor
        {
            public string FullName;
            public int FlatNumber;
            public int PhoneNumber;

            public override string ToString()
            {
                return $"The neighor - {FullName}, his/her number - {PhoneNumber}";
            }

        }

        public static void DictionaryOfNeighborSearch()
        {
            Dictionary<int, Neighbor> floorNeighbors = new Dictionary<int, Neighbor>();
            floorNeighbors.Add(1, new Neighbor() { FullName = "Petrov", FlatNumber = 1, PhoneNumber = 7512548 });
            floorNeighbors.Add(2, new Neighbor() { FullName = "Sidorov", FlatNumber = 2, PhoneNumber = 4587963 });
            floorNeighbors.Add(3, new Neighbor() { FullName = "Kuzin", FlatNumber = 3, PhoneNumber = 7589638 });
            floorNeighbors.Add(4, new Neighbor() { FullName = "Fomenok", FlatNumber = 4, PhoneNumber = 4512645 });

            floorNeighbors.Remove(4);

            var numberofFlat = int.Parse(Console.ReadLine());
            var neighbor = floorNeighbors[numberofFlat];

            Console.WriteLine(neighbor);
            
        }
    }
}
