namespace Lab4
{
    public class AverageAge
    {
        private double _sumOfAllAges;
        private int _totalNumberOfPeople;
        public void AddPerson(Person person)
        {
            _totalNumberOfPeople++;
            _sumOfAllAges += person.Age;
            if (person.Spouse != null)
            {
                _totalNumberOfPeople++;
                _sumOfAllAges += person.Spouse.Age;
            }
        }
               
        public double Get()
         {
            return _sumOfAllAges / _totalNumberOfPeople;       
         }                
    }
}