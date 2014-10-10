namespace Employee_Salary_App
{
    internal class Salary
    {
        public double BasicSalary {get; private  set; }
        private double MedicalParcentagesOfBasic;
        private double ConveyanceParcentageOfBasic;
        private double Increase;
        public int NoOfIncrement { get; private set; }
        private double totalIncrement;


        public double Medical()
        {
            return MedicalParcentagesOfBasic*BasicSalary/100;
        }

        public double Conveyance()
        {
            return ConveyanceParcentageOfBasic*BasicSalary/100;
        }

        public double Total()
        {
            return BasicSalary + Medical() + Conveyance() + totalIncrement;
        }
        public void Increment(double increaseParcentageOfBasic)
        {
            Increase = increaseParcentageOfBasic;
            double increment=increaseParcentageOfBasic*BasicSalary/100;
            totalIncrement += increment;
            NoOfIncrement++;
        }

        public Salary(double basicSalary, double medicalParcentagesOfBasic, double conveyanceParcentageOfBasic)
        {
            BasicSalary = basicSalary;
            MedicalParcentagesOfBasic = medicalParcentagesOfBasic;
            ConveyanceParcentageOfBasic = conveyanceParcentageOfBasic;
        }
    }
}