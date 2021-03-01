using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inputs;

namespace Class_Collection
{
    //This class was created special for working with SuperObject
    public class SuperObjectManager
    {
        SuperCollection<SuperObject> Collection = new SuperCollection<SuperObject>();

        public void ShowElements()
        {
            SuperObject[] array = Collection.GetArray();
            if (array.Length == 0)
            {
                Console.WriteLine("Collection is empty!");
            }
            else
            {
                for (int i = 0; i < Collection.Count(); i++)
                {
                    Console.WriteLine($"Id: {i}");
                    array[i].ShowObject();
                    Console.WriteLine();
                }
            }           
        }

        public void AddElement()
        {
            SuperObject element = AddObject();
            Collection.AddElement(element);
        }
        SuperObject AddObject()
        {
            Console.Write("Name: ");
            string Name = Console.ReadLine();
            Console.Write("Number: ");
            int Number = NumbersInput.Integer("Number: ");

            return new SuperObject(Name, Number);
        }

        public void SortName()
        {
            SuperObject[] array = Collection.GetArray();
            int arraySize = Collection.Count();

            for (int i = 0; i < arraySize; i++)
            {
                for (int x = 1; x < arraySize; x++)
                {
                    if (array[x].Name.Length < array[x - 1].Name.Length)
                    {
                        SuperObject temp = array[x];
                        array[x] = array[x - 1];
                        array[x - 1] = temp;
                    }
                }
            }
        }
        public void SortNumber()
        {
            SuperObject[] array = Collection.GetArray();
            int arraySize = Collection.Count();

            for (int x = 0; x < arraySize; x++)
            {
                for (int i = 1; i < arraySize; i++)
                {
                    if (array[i].Number < array[i - 1].Number)
                    {
                        SuperObject temp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = temp;
                    }
                }
            }   
        }

        public void RemoveElement()
        {
            Collection.RemoveElement();
        }
        public void RemoveAll()
        {
            Collection.RemoveAll();
        }

        public void Search()
        {
            Collection.BinarySearch().ShowObject();
        }

        public bool IsEmpty()
        {
            return Collection.IsEmoty();
        }
    }
}
