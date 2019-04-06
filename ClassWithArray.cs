namespace Practice_22_01
{
    public class ClassWithArray
    {
        const int DEFAULT_SIZE = 5;

        private int[] array;
        public int Size { get; }

        public ClassWithArray(int cnt)
        {
            if(cnt > 0)
            {
                array = new int[cnt];
            }
            else
            {
                array = new int[DEFAULT_SIZE];
            }
            Size = array.Length;
        }

        public static bool operator <(ClassWithArray class1, ClassWithArray class2)
        {
            int sum1 = 0, sum2 = 0;

            for(int i = 0; i < class1.array.Length; i++)
            {
                sum1 += class1[i];
            }
            for (int i = 0; i < class2.array.Length; i++)
            {
                sum2 += class2[i];
            }

            if(sum1 < sum2)
            {
                return true;
            }
            return false;

        }

        public static bool operator>(ClassWithArray class1, ClassWithArray class2)
        {
            int sum1 = 0, sum2 = 0;

            for (int i = 0; i < class1.array.Length; i++)
            {
                sum1 += class1[i];
            }
            for (int i = 0; i < class2.array.Length; i++)
            {
                sum2 += class2[i];
            }

            if (sum1 > sum2)
            {
                return true;
            }
            return false;
        }

        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
