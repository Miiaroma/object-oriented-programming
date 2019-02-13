using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_task
{
    class Customer : ICustomer
    {
        private string _cName;
        private double _purchase;

        public Customer()
        {
            _cName = String.Empty;
            _purchase = 0;
        }
        
        public Customer(string cName, double purchase)
        {
            this._cName = cName;
            this._purchase = purchase;
        }

        public override string ToString()
        {
            return $"Asiakas: {this._cName}\nOstos: {this._purchase:c}\nBonus: {this.GetBonus():c}\n";
        }

        public Customer GetCustomer(string compareName)
        {
            if (this._cName == compareName)
            {
                return this;
            }
            else
            {
                return null;
            } 
        }

        public double GetBonus()
        {
            if (_purchase <= 1000)
            {
                return _purchase * 0.02;
            }

            else if (_purchase > 1000 && _purchase < 2000)
            {
                return _purchase * 0.03;
            }

            else
            {
                return _purchase * 0.05;
            }
            
        }
    }
}


