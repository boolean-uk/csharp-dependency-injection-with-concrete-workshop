using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VW.Factory.CarParts;

namespace VW.Factory.Cars
{
    public class Beetle
    {
       
        private Bonnet _bonnet;
        private Engine _engine;

        //constructor overloading
        public Beetle()
        {
            _engine = new Engine();
            _bonnet = new Bonnet();                    
        }
        public Beetle(string NumberToPutOnBonnet, ElectricEngineParts engineParts)
        {
            _engine = new Engine(engineParts);
            _bonnet = new Bonnet(NumberToPutOnBonnet);
        }
        public Beetle(string NumberToPutOnBonnet, DieselEngineParts engineParts)
        {
            _engine = new Engine(engineParts);
            _bonnet = new Bonnet(NumberToPutOnBonnet);
        }
        public Beetle(string NumberToPutOnBonnet, PetrolEngineParts engineParts)
        {
            _engine = new Engine(engineParts);
            _bonnet = new Bonnet(NumberToPutOnBonnet);
        }


        //method overloading
        public void SelfDriveMode(int averageSpeed, string cityDestination)
        {
            //sets an average speed and destination city for the car
        }
        public void SelfDriveMode(int averageSpeed)
        {
            //sets an average speed for the self drive mode but car could go anywhere
        }
        public void SelfDriveMode()
        {
            //auto drive mode where anything could happen
        }                       
        public void SelfDriveMode(bool disableFeature)
        {

        }

    }
}
