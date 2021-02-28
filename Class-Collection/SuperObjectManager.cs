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

            for (int i = 0; i < Collection.Count(); i++)
            {
                for (int x = 1; x < Collection.Count(); x++)
                {
                    int comparisonValue = array[x].Name.CompareTo(array[x - 1].Name);
                    if (comparisonValue >= 0)
                    {
                        SwapObjects(array[x], array[x - 1]);
                    }
                }
            }  
        }
        public void SortNumber()
        {
            SuperObject[] array = Collection.GetArray();
            
            for (int x = 0; x < Collection.Count(); x++)
            {
                for (int i = 1; i < Collection.Count(); i++)
                {
                    if (array[i].Number > array[i - 1].Number)
                    {
                        SwapObjects(array[i], array[i - 1]);
                    }
                }
            }   
        }
        void SwapObjects(SuperObject obj1, SuperObject obj2)
        {
            SuperObject temp = obj1;
            obj1 = obj2;
            obj2 = temp;
        }

        public void RemoveElement()
        {
            Collection.RemoveElement();
        }
        public void RemoveAll()
        {
            Collection.RemoveAll();
        }

        public bool IsEmpty()
        {
            return Collection.IsEmoty();
        }
    }
}
