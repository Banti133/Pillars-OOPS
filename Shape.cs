using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillars_OOPS
{
    internal class Shape <T>
    {
        //private field to hold the shape name
        private T shapeName;
        public Shape()
        {
            shapeName = default(T); //initialize the shape name to default value
        }
        public Shape(T name)
        {
            shapeName = name; //initialize the shape name
        }
        public T ShapeName
        {
            get { return shapeName; } //get the shape name
            set { shapeName = value; } //set the shape name
        }
        public override string ToString()
        {
            return $"Shape Name: {shapeName}"; //return the shape name as a string
        }





    }
}
