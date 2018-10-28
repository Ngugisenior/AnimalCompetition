using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AnimalCompetition {
    //Class Definition
    public class Animal {

        //Fields
        public Animal (string name, int birthYear, int beautyPoint, int behaviourPoint) {
            this.Name = name;
            this.BirthYear = birthYear;
            this.BeautyPoint = beautyPoint;
            this.BehaviourPoint = behaviourPoint;
        }
//Variable type Objects
        public string Name { get; set; }
        public int BirthYear { get; set; }
        public int BeautyPoint { get; private set; }
        private int BehaviourPoint { get; set; }
        public static int AgeLimit;
        public static int ActualYear;

        //methods
        public void Scoring (int beautyPoint, int behaviourPoint) {
            this.BeautyPoint = beautyPoint;
            this.BehaviourPoint = behaviourPoint;
        }
        public int Age () {
            return ActualYear - BirthYear;
        }

        public virtual int Score () {
            if (Age () < AgeLimit) {
                return BehaviourPoint * Age () + BeautyPoint * (AgeLimit - Age ());
            }
            return 0;
        }
        public override string ToString () {
            return Name + this.Age () + this.Score ()+"\n";
        }

    }
}