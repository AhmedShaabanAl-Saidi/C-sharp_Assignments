using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_C_
{
    public class ListMethods<T>
    {
        // Part 03:
        // 3.We need to Implement the List methods from scratch with all overloads.
        // Exists
        public static bool Exists(Predicate<T> match, List<T> items)
        {
            if (match == null)
                return false;

            for (int i = 0; i < items.Count; i++)
            {
                if (match.Invoke(items[i]))
                    return true;
            }
            return false;
        }

        // Find
        public static T Find(Predicate<T> match, List<T> items)
        {
            if (match == null)
                return default;

            for (int i = 0; i < items.Count; i++)
            {
                if (match.Invoke(items[i]))
                    return items[i];
            }
            return default;
        }

        // Find All
        public static List<T> FindAll(Predicate<T> match, List<T> items)
        {
            List<T> newList = new List<T>();

            if (match == null)
                return default;

            for (int i = 0; i < items.Count; i++)
            {
                if (match.Invoke(items[i]))
                    newList.Add(items[i]);
            }
            return newList;
        }

        // Find index
        public static int FindIndex(Predicate<T> match, List<T> items)
        {
            if (match == null)
                return -1;

            for (int i = 0; i < items.Count; i++)
            {
                if (match.Invoke(items[i]))
                    return i;
            }
            return -1;
        }

        public static int FindIndex(Predicate<T> match,int startIndex, List<T> items)
        {
            if (match == null)
                return -1;

            for (int i = startIndex; i < items.Count; i++)
            {
                if (match.Invoke(items[i]))
                    return i;
            }
            return -1;
        }

        public static int FindIndex(Predicate<T> match, int startIndex ,int count, List<T> items)
        {
            if (match == null)
                return -1;

            for (int i = startIndex; i < count; i++)
            {
                if (match.Invoke(items[i]))
                    return i;
            }
            return -1;
        }

        // Find Last
        public static T FindLast(Predicate<T> match, List<T> items)
        {
            if (match == null)
                return default;

            for (int i = items.Count-1; i >= 0; i--)
            {
                if (match.Invoke(items[i]))
                    return items[i];
            }
            return default;
        }

        // Find Last Index
        public static int FindLastIndex(Predicate<T> match, List<T> items)
        {
            if (match == null)
                return -1;

            for (int i = items.Count-1 ; i >= 0 ; i--)
            {
                if (match.Invoke(items[i]))
                    return i;
            }
            return -1;
        }

        public static int FindLastIndex(Predicate<T> match, int startIndex, List<T> items)
        {
            if (match == null)
                return -1;

            for (int i = startIndex; i >= 0; i--)
            {
                if (match.Invoke(items[i]))
                    return i;
            }
            return -1;
        }

        public static int FindLastIndex(Predicate<T> match, int startIndex, int count, List<T> items)
        {
            if (match == null)
                return -1;

            int endIndex = startIndex - count + 1; 

            for (int i = startIndex; i >= endIndex; i--)
            {
                if (match.Invoke(items[i]))
                    return i;
            }
            return -1;
        }

        // ForEach
        public static void ForEach(List<T> items, Action<T> action)
        {
            if (items == null || action == null)
                return;

            foreach (T item in items)
                action(item);
        }

        // TrueForAll
        public static bool TrueForAll(List<T> items, Predicate<T> match)
        {
            if (items == null || match == null)
                return false;

            foreach (T item in items)
            {
                if (!match(item))
                    return false;
            }
            return true;
        }
    }
}
