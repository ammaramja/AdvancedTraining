using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_august_assignments
{
    class QuestionPaper
    {
        public int findLargestQuestionBank(int[] questionBankArray)
        {
            int numberOfQuestionBanks = questionBankArray.Length;
            int largestQuestionBank = -999;
            int indexOfLargestQuestionBank = 0;

            for(int i = 0 ;i < numberOfQuestionBanks ; i++)
            {
                if(largestQuestionBank < questionBankArray[i])
                {
                    largestQuestionBank = questionBankArray[i];
                    indexOfLargestQuestionBank = i;
                }
            }
            return indexOfLargestQuestionBank;
        }
        public void inputData()
        {
            Console.WriteLine("Enter number of question banks :");
            int numberOfQuestionBanks = Convert.ToInt32(Console.ReadLine());

            int[] questionBankArray = new int[numberOfQuestionBanks];

            Console.WriteLine("Enter count of questions in each question bank!");

            int sum = 0;
            for(int i = 0; i< numberOfQuestionBanks; i++)
            {
                questionBankArray[i] = Convert.ToInt32(Console.ReadLine());
                sum += questionBankArray[i];
            }
            StringBuilder finalQuestionPaper = new StringBuilder();

            int LargestQuestionBank = findLargestQuestionBank(questionBankArray);

            //finalQuestionPaper.Append("");

            foreach (int questions in questionBankArray)
            {
                if (questions > (sum - questions) + 1)
                {
                    Console.WriteLine("Not possible!");
                    Console.ReadLine();
                    System.Environment.Exit(0);
                }
            }

            Console.WriteLine("Order of questions would be as follows:");
            Console.WriteLine();
            Console.WriteLine((Convert.ToChar(65 + LargestQuestionBank))+""+ questionBankArray[LargestQuestionBank]);

            int currentQuestionBank = LargestQuestionBank;
            questionBankArray[currentQuestionBank]--;

            for (int i = 0 ; i < sum - 1 ; i++)
            {
                LargestQuestionBank = findLargestQuestionBank(questionBankArray);

                    if ((LargestQuestionBank != currentQuestionBank))
                    {
                        currentQuestionBank = LargestQuestionBank;
                        Console.WriteLine(Convert.ToChar(65 + LargestQuestionBank) + "" + questionBankArray[currentQuestionBank]);
                        questionBankArray[currentQuestionBank]--;
                    }
                    else
                    {
                        int max = -99;
                        int nexLargestQuestionBank = 0;
                        for (int iterator = 0; iterator < questionBankArray.Length; iterator++)
                        {
                            if (questionBankArray[iterator] > max && iterator != LargestQuestionBank && iterator != currentQuestionBank)
                            {
                                max = questionBankArray[iterator];
                                nexLargestQuestionBank = iterator;
                                //Console.WriteLine("max : " + max + "  zdcsdvf" + nexLargestQuestionBank);
                            }

                        }
                        LargestQuestionBank = nexLargestQuestionBank;
                        currentQuestionBank = LargestQuestionBank;
                        //Console.WriteLine(LargestQuestionBank);
                        //currentQuestionBank = LargestQuestionBank-1;
                        Console.WriteLine(Convert.ToChar(65 + LargestQuestionBank) + "" + questionBankArray[currentQuestionBank]);
                        questionBankArray[currentQuestionBank]--;
                    }
                }
            Console.ReadLine();
        }
    }
}
