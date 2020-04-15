using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace genericList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many items do you want in your shopping list?");
            //check for format errors:
            bool success = false;
            int numberofitems = 0;
            while (success == false)
            {
                try
                {
                    numberofitems = int.Parse(Console.ReadLine());
                    success = true;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("please write a number");
                }
            }
            string[] items = new string[numberofitems];
            //continue adding until numberofitems value runs out
            for (int i = 0; i < numberofitems; i++)
            {
                Console.WriteLine("add something");
                string addToItemsArray = Console.ReadLine();
                items[i] = addToItemsArray;
            }
            //automatically print all items in list
            Console.WriteLine("all items currently in your list:");
            for (int i = 0; i < numberofitems; i++)
            {
                Console.WriteLine(items[i]);
            }
            while (true)
            {//always ask to add, remove, view, or exit until loop breaks:
                Console.WriteLine("do you want to add(1), remove(2), view(3), or exit(4)");
                bool success2 = false;
                int checkWhatToDo = 0;
                while (success2 == false)
                {
                    try
                    {
                        checkWhatToDo = int.Parse(Console.ReadLine());
                        success2 = true;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("please write a number");
                    }
                }
                if (checkWhatToDo == 1)
                {
                    //override old array for extra array spot:
                    //first make an entirely different array that is 1 larger in length than the old array
                    //then make a for loop, and transfer all items from the old array to the new array
                    //after we transfer the items, ask the user to enter the item they want to add
                    //take this item, and place it into the last space of the new array
                    //once this is done, set the old array = new array(final step for override)
                    string[] newArrayItems = new string[items.Length + 1];
                    for (int i = 0; i < items.Length; i++)
                    {
                        newArrayItems[i] = items[i];
                    }
                    Console.WriteLine("what do you want to add in the new array empty spot?");
                    string newItemSpot = Console.ReadLine();
                    newArrayItems[newArrayItems.Length - 1] = newItemSpot;
                    items = newArrayItems;
                }
                else if (checkWhatToDo == 2)
                {
                    //override old array for one less spot(desired item removed along with designated array space):
                    string[] newArrayItems = new string[items.Length - 1];
                    Console.WriteLine("remove what from list?");
                    string doesTheValueExist = Console.ReadLine();
                    bool exists = false;
                    //check to see if value exists
                    for (int i = 0; i < items.Length; i++)
                    {
                        if (doesTheValueExist == items[i])
                        {
                            exists = true;
                        }
                    }

                    if (exists == true)
                    {
                        int replacementIndex = 0;
                        for (int i = 0; i < items.Length; i++)
                        {
                            if (doesTheValueExist == items[i])
                            {
                                i++;
                            }
                            newArrayItems[replacementIndex] = items[i];
                            replacementIndex++;
                        }
                        items = newArrayItems;
                    }
                    else
                    {
                        Console.WriteLine("this item does not exist in your list");
                    }
                }
                //print all items in array
                else if (checkWhatToDo == 3)
                {
                    Console.WriteLine("all items currently in your list:");
                    for (int i = 0; i < items.Length; i++)
                    {
                        Console.WriteLine(items[i]);
                    }
                }
                else if (checkWhatToDo == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("this choice does not exist");
                }
            }
        }
    }
}
