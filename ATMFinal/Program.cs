using System;

namespace ATM
{
    class ATMProgram
    {
        private int hundred;
        private int fifty;
        private int twenty;
        private int ten;
        private int five;
        private int one;

        public ATMProgram()
        {
            hundred = 10;
            fifty = 10;
            twenty = 10;
            ten = 10;
            five = 10;
            one = 10;
        }

        public void status()
        {
            Console.WriteLine("Machine Status: \n$100 - " + hundred + "\n$50 - " + fifty + "\n$20 - " + twenty + "\n$10 - "
                     + ten + "\n$5 - " + five + "\n$1 - " + one);
        }

        public void restock()
        {
            hundred = 10;
            fifty = 10;
            twenty = 10;
            ten = 10;
            five = 10;
            one = 10;
            this.status();
        }

        public void withdraw(int amount)
        {
            int total = hundred * 100 + fifty * 50 + twenty * 20 + ten * 10 + five * 5 + one;
            if (amount > total)
            {
                Console.WriteLine("Failure: Insufficient funds");
                return;
            }
            if (amount % 5 > one)
            {
                Console.WriteLine("Failure: Insufficient funds");
                return;
            }
            // 100
            Console.WriteLine("Success: Withdrew $" + amount);
            int numHundred = amount / 100;
            if (hundred >= numHundred)
            {
                hundred -= numHundred;
            }
            else
            {
                numHundred = hundred;
                hundred = 0;
            }
            amount -= (numHundred * 100);
            // 50
            int numFifty = amount / 50;
            if (fifty >= numFifty)
            {
                fifty -= numFifty;
            }
            else
            {
                numFifty = fifty;
                fifty = 0;
            }
            amount -= (numFifty * 50);
            // 20
            int numTwenty = amount / 20;
            if (twenty >= numTwenty)
            {
                twenty -= numTwenty;
            }
            else
            {
                numTwenty = twenty;
                twenty = 0;
            }
            amount -= (numTwenty * 20);
            // 10
            int numTen = amount / 10;
            if (ten >= numTen)
            {
                ten -= numTen;
            }
            else
            {
                numTen = ten;
                ten = 0;
            }
            amount -= (numTen * 10);
            // 5
            int numFive = amount / 5;
            if (five >= numFive)
            {
                five -= numFive;
            }
            else
            {
                numFive = five;
                five = 0;
            }
            amount -= (numFive * 5);
            // 1
            int numOne = amount;
            if (one >= numOne)
            {
                one -= numOne;
            }
            else
            {
                Console.WriteLine("Failure: Insufficient funds");
            }
            this.status();
        }

        public int getHundreds()
        {
            return hundred;
        }

        public int getFifty()
        {
            return fifty;
        }

        public int getTwenty()
        {
            return twenty;
        }

        public int getTens()
        {
            return ten;
        }

        public int getFives()
        {
            return five;
        }

        public int getOnes()
        {
            return one;
        }




    }
}
