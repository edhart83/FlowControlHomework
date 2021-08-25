using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FlowControlHomework
{
    [TestClass]
    public class FlowControlHomework
    {
        [TestMethod]
        public void IfFundementals() // THE GOAL IS TO CHANGE THE FLOW TO REACH ALL THE PASSING STATEMENTS AND TO FIX COMPILATION ISSUES
        {
            bool changeFlow = false; // assign me so I can reach line 14 in my flow of execution
            if (changeFlow)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            changeFlow = false; // assign me so I can reach line 24 in my flow of execution
            if (changeFlow)
            {
                Assert.IsTrue(false);
            }
            else
            {
                Assert.IsTrue(true);
            }

            changeFlow = false; // assign me so I can reach line 38 in my flow of execution
            if (changeFlow)
            {
                //  Change the flow with the same variable;

                if (changeFlow == false)
                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                Assert.IsTrue(false);
            }

            changeFlow = true; // assign me so I can reach line 54 in my flow of execution
            bool nextChangeFlow = false; // assign me so I can reach line 54 in my flow of execution
            if (changeFlow)
            {
                Assert.IsTrue(false);
            }
            else if (nextChangeFlow)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            changeFlow = true; // assign me so I can reach line 73 in my flow of execution
            nextChangeFlow = true; // assign me so I can reach line 73 in my flow of execution
            if (changeFlow)
            {
                Assert.IsTrue(false);
            }
            else if (nextChangeFlow)
            {
                Assert.IsTrue(false);
            }
            else
            {
                Assert.IsTrue(true);
            }

            // Uncomment and fix me so I compile.
            //if true
            //{
            //    
            //}

        }


        [TestMethod]
        public void IfWithOperators()
        {
            // This section is testing that you know what these operators do, provide operands to reach the pass statements.
            // you can do this in may ways as long as you prove operands in the appropriate place.
            
            if (/*operand here*/ == /*operand here*/)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            if (/*operand here*/ != /*operand here*/)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            if (/*operand here*/ < /*operand here*/)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            if (/*operand here*/ > /*operand here*/)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            if (/*operand here*/ <= /*operand here*/)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            if (/*operand here*/ >= /*operand here*/)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            if (!/*operand here, do not remove not operator*/)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            if (!!/*operand here, do not remove double not operator*/)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            if ((/*operand here*/ == /*operand here*/) && (/*operand here*/ == /*operand here*/))
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            if ((/*operand here*/ == /*operand here*/) || (/*operand here*/ == /*operand here*/))
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }

            int inRange = 0; // Set this value to pass BOTH the range checks, do not reassign it.
            if (inRange < 10 && inRange > 5)
            {
                if ( inRange < 7 && inRange > 5)
                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void Switch()
        {
            int number = 0; //Assign me so I cause the next switch to pass.
            switch (number)
            {
                case 15:
                    Assert.IsTrue(false);
                    break;
                case 26:
                    Assert.IsTrue(true);
                    break;
                default:
                    Assert.IsTrue(false);
                    break;
            }

            number = 0; //Assign me so I cause the next switch to pass.
            switch (number)
            {
                case 15:
                    Assert.IsTrue(false);
                    break;
                case 26:
                    Assert.IsTrue(false);
                    break;
                default:
                    Assert.IsTrue(true);
                    break;
            }

            number = 0;  //Assign me so I cause the next switch to pass.
            switch (number)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    Assert.IsTrue(true);
                    break;
            }


            // These have compilation issues, there is no logic error, uncomment and fix them
            //string usersChoice = "c"; 
            //switch (usersChoice) // Fix me so I compile
            //{
            //    case "a":
            //        Assert.IsTrue(false);
            //        break;
            //    case "b":
            //        Assert.IsTrue(false);
            //        break;
            //    case "c":
            //        Assert.IsTrue(true);
            //    default:
            //        Assert.IsTrue(false);
            //        break;
            //}

            //switch (usersChoice) // Fix me so I compile
            //{
            //    case "a":
            //        Assert.IsTrue(false);
            //        break;
            //    case "b";
            //        Assert.IsTrue(false);
            //        break;
            //    case "c";
            //        Assert.IsTrue(true);
            //        break;
            //    default:
            //        Assert.IsTrue(false);
            //        break;
            //}

            //switch (usersChoice) // Fix me so I compile
            //    case "a":
            //        Assert.IsTrue(false);
            //        break;
            //    case "b":
            //        Assert.IsTrue(false);
            //        break;
            //    case "c":
            //        Assert.IsTrue(true);
            //        break;
            //    default:
            //        Assert.IsTrue(false);
            //        break;
            //}

        }


        [TestMethod]
        public void Loops()
        {

            int max = 0; // set me correctly so i reach the assert pass.
            for(int i =0; i <= max; i++)
            {
                // DONT BE ALARMED, you dont need brackets if its only a single statement you want to execute. Im just exposing you to this because programmers do it
                if (i == 15) Assert.IsTrue(true);
            }

            max = 17;
            // Almost the same as above but you need to do something special to get to 16.
            // Some restrictions:
            // Dont change anything in the block, only the for statement.
            // hint: you dont need increment by 1.
            // This one is tough, take your time.
            for (int i = 0; i <= max; i++)
            {
                bool isOdd = !((i % 2) == 0); // notice how the variable explains the expression? 
                if(isOdd)
                {
                    // if you reach here test will fail. 
                    Assert.IsTrue(false);
                }

                if (i == 16) Assert.IsTrue(true);
            }

            // break out of the loop after the test passes at least once, there are a couple ways do to this
            int counter = 0;  // Change me to get in.
            while (counter < 15 && counter > 1)
            {
                Assert.IsTrue(true);
                Console.WriteLine("IM STUCK IN HERE");
                // Something here to get me out. there are a few ways.
            }

            int count = 0;
            do
            {
                if(count > 0)
                {
                    Assert.IsTrue(true);
                }
                count++;
            } while ( /* write an expression here to get the loop to continue to run.*/); 

        }
    }
}
