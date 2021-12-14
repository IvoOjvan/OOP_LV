using System;
using System.Collections.Generic;
using System.Text;

namespace Zadatak_2
{
    public class Vector
    {
        #region Properties
        private double icomponent;
        private double jcomponent;
        private double kcomponent;

        public double iComponent
        {
            get { return this.icomponent; }
        }

        public double jComponent
        {
            get { return this.jcomponent; }
        }

        public double kComponent
        {
            get { return this.kcomponent; }
        }
        #endregion

        #region Constructor
        public Vector(double icomponent, double jcomponent, double kcomponent)
        {
            this.icomponent = icomponent;
            this.jcomponent = jcomponent;
            this.kcomponent = kcomponent;
        }

        public Vector() : this(0,0,0){  }
        #endregion

        #region Methods
        public string ShowVector()
        {
            return $"{iComponent}i + {jComponent}j + {kComponent}k";
        }
        #endregion

        #region Operators
        public static Vector operator+ (Vector v1, Vector v2)
        {
            return new Vector(v1.iComponent + v2.iComponent, v1.jComponent + v2.jComponent, v1.kComponent + v2.kComponent);
        }

        public static Vector operator- (Vector v1, Vector v2)
        {
            return new Vector(v1.iComponent - v2.iComponent, v1.jComponent - v2.jComponent, v1.kComponent - v2.kComponent);
        }

        #endregion
    }
}
