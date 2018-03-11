using System;
using System.Collections.Generic;
using System.Linq;

public class Exercise15 {

    public static void xoaphantu () {
        try {
            string input;
            System.Console.Write ("nhap vao chuoi input = ");
            input = Convert.ToString (Console.ReadLine ());
            int l = input.Length;
            int vitri;
            while (l > 0) {
                System.Console.Write ("nhap vao vi tri muon xoa k = ");
                vitri = Convert.ToInt32 (Console.ReadLine ());
                string num = input.Remove (vitri, 1);
                System.Console.WriteLine (num);
                input = num;
            }
        } catch (System.Exception e) {
            System.Console.WriteLine (e.Message);
        } finally {
            System.Console.WriteLine ("ket thuc chuong trinh !!!!");
        }
    }
    public static void themvaodaucuoi () {
        string input;
        System.Console.Write ("moi ban nhap ki tu input = ");
        input = Convert.ToString (Console.ReadLine ());
        char[] converts = input.ToCharArray ();
        string result = "";
        string num = "";
        for (int i = 0; i < 1; i++) {
            result += converts[0];
        }
        for (int i = 0; i < converts.Length; i++) {
            num += converts[i];
        }
        System.Console.Write (result + num + result);
    }
    public static void xoatungkitumoi () {
        string input;
        System.Console.Write ("hay nhap chuoi input = ");
        input = Console.ReadLine ();
        char[] array = input.ToCharArray ();
        int l = array.Length;
        int i =0;

        while (i<l) {
                System.Console.WriteLine ();
                System.Console.Write ("nhap ki tu ban muon xoa char = ");
                char input2 = Convert.ToChar (Console.ReadLine ());
                if (input2 == array[i]) {
                    array[i] -= array[i];
                }
                Console.Write (array[i]);  
                i++;
            }
        }
      public static void fibonacci()
      {
         int a=0,b=1,input;
         System.Console.Write("nhap vao input = ");
         input = Convert.ToInt32(Console.ReadLine());
         for (int i = 0; i < input; i++)
         {
             int temp = a;
             a=b;
             b=temp+b;
             System.Console.WriteLine(a);
         }
      }
     
      public static void addlist()
      {
           System.Console.Write("nhap do dai cua list  n = ");
           int n = Convert.ToInt32(Console.ReadLine());
           string[] array = new string[n]; 
           for (int i = 0; i <n; i++)
           {
               System.Console.Write("nhap phan Sinh vien[{0}] = ",i);
               array[i] = Convert.ToString(Console.ReadLine());
           
           }
             List<String> list = new List<String>();
         
           for (int i = 0; i <array.Length; i++)
           {
              list.Add(array[i]);
           }
            System.Console.Write("ban muon them ten Sinh Vien  = ");
            String value = Convert.ToString(Console.ReadLine());
             System.Console.Write("nhap vi tri ban muon them index = ");
             int index = Convert.ToInt32(Console.ReadLine());
             list.Insert(index,value);  //Insert la thêm vào vị trí thứ index của mảng;
             System.Console.WriteLine("array Cua ban  la :");
            //  list.Sort();
           for (int i = 0; i < list.Count; i++)
           {
               System.Console.WriteLine(list[i] + " ");
           }
      }

       public static void sort()
        {
            int[] array = new int[]{2,1,4,5,3};
            for (int i = 0; i <array.Length; i++)
            {
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] =array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (var item in array)
            {
                System.Console.Write(item+" ");
            }
        }
    static void Main (string[] args) {
        // xoaphantu();
        // Exercise15.themvaodaucuoi();
        // xoatungkitumoi();
        // fibonacci();
        // sort();
        // addlist();
    }
}
