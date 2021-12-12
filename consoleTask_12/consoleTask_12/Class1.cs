using System;
using System.Collections.Generic;
using System.Text;

namespace consoleTask_12
{
    class Class1
    {
        int[] m_IntArray;
        int n;
        public Class1(int n)
        {
            this.n = n;
            m_IntArray = new int[n];
        }
        public Class1():this(0)
        {

        }
        public int this[int i]
        {
            get
            {
                return m_IntArray[i];
            }
            set
            {
                m_IntArray[i] = value;
            }
        }

        public void Input(string str)
        {
            string[] str2 = str.Split(' ');
            if(str2.Length>m_IntArray.Length || str2.Length < m_IntArray.Length)
            {
                throw new Exception("Некорректное количество введенных элементов");
            }
            else
            {
                for (int i=0; i<m_IntArray.Length; i++)
                {
                    m_IntArray[i] = int.Parse(str2[i]);
                }
            }
        }
        public void Input(int []arr)
        {
            for (int i = 0; i < m_IntArray.Length; i++)
            {
                m_IntArray[i] = arr[i];
            }
        }
        public string Show()
        {
            string str = String.Empty;
            foreach(int a in m_IntArray)
            {
                str += a + " ";
            }
            return str;
        }
        public void Sort()
        {
            for (int i=0; i<m_IntArray.Length; i++)
            {
                for (int j =0; j<m_IntArray.Length-1; j++)
                {
                    if (m_IntArray[j]>m_IntArray[j+1])
                    {
                        int buf = m_IntArray[j+1];
                        m_IntArray[j + 1] = m_IntArray[j];
                        m_IntArray[j] = buf;
                    }
                }
            }
        }
        public int Length
        {
            get
            {
                return m_IntArray.Length;
            }
        }
        public int Skal
        {
            set
            {
                for (int i = 0; i < m_IntArray.Length; i++)
                {
                    m_IntArray[i] *= value;
                }
            }
        }
        static public Class1 operator++(Class1 a)
        {
            Class1 b = a;
            for (int i=0; i<b.Length; i++)
            {
                b[i] = b[i] + 1;
            }
            return b;
        }
        static public Class1 operator --(Class1 a)
        {
            Class1 b = a;
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = b[i] - 1;
            }
            return b;
        }
        static public bool operator !(Class1 a)
        {
            for (int i=0; i<a.Length-1; i++)
            {
                if (a[i] > a[i + 1])
                    return true;
            }
            return false;
        }
        static public Class1 operator *(Class1 a, int s)
        {
            Class1 b = a;
            for (int i = 0; i<b.Length; i++)
            {
                b[i] = b[i] * s;
            }
            return b;
        }
        static public explicit operator Class1(int[]arr)
        {
            Class1 a = new Class1(arr.Length);
            a.Input(arr);
            return a;
        }
        static public explicit operator int[](Class1 a)
        {
            int[] arr = new int[a.Length];
            for (int i=0; i<a.Length; i++)
            {
                arr[i] = a[i];
            }
            return arr;
        }
    }
}
