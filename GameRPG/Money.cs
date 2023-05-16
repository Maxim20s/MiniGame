namespace GameRPG
{
    class Balance
    {
        private int money;

        public int Money { get => money; set => money = value; }  

        public void AddBalance()
        {
            money++;
        }
        public void PutAwayBalance(int money)
        {
            money =- money;
        }
    }
}
