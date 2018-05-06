namespace assessmentQ2
{

    class Car {

        public string Colour {get; set;}

        public string Make {get; set;}

        public string Gearbox {get; set;}



        public string DescribeCar() {

            return $"This car is a {Make} and is {Colour}, the transmission is a {Gearbox}.";

        }

    }

}