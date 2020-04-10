using System;
namespace PersonalProjectLab
{
    public class OilReading
    {
        //assign variables
        int _problemLowPress;
        int _problemHighPress;       
        int _actualOilPress;
        bool _enginesafe = true;
        

        public OilReading(int MinPress, int MaxPress)
        {
            _problemLowPress = MinPress;
            _problemHighPress = MaxPress;
            
        }
        public void UpdateOilSensorPress(int OilPress)
        {
            _actualOilPress = OilPress;
            CheckOilSensor();
        }

        public String CheckOilSensor()
        {
            String R;
            if (_actualOilPress > _problemLowPress && _actualOilPress<_problemHighPress)
            {
                R = "true";
            }
            else
            {
                R = "false";
            }

            return R;
        }  

        public bool EngineSecurity()
        {
            return _enginesafe;
        }

        
    }
      
}
