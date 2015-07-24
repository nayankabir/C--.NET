using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2Practice_Question_7
{
    public class RecoveringDemo
    {
        private string _patient, _upholsterer, _footballPlayer;
        private int _recoveryRate;

        public RecoveringDemo(string patient, string upholsterer, string footballplayer, int recoveryRate)
        {
            this._patient = patient;
            this._upholsterer = upholsterer;
            this._footballPlayer = footballplayer;
            this._recoveryRate = recoveryRate;

            Console.WriteLine("Please enter recovery rate from 0-10");
            Console.WriteLine("Patient is {0}", _patient);

            _recoveryRate = Convert.ToInt32(Console.ReadLine());
            Recover();
        }

        public bool Recover()
        {
            bool isRecovering = false;

            while (isRecovering != true)
            {
                _patient = "Normal";
                _upholsterer = "Normal";
                _footballPlayer = "Normal";

                if (_recoveryRate >= 5)
                {
                    _patient = "Abnormal";
                    _upholsterer = "Abnormal";
                    _footballPlayer = "Abnormal";
                    isRecovering = true;
                }
            }
            return isRecovering;
        }
    }
}