namespace AnimalCompetition
{
    //Class Definition
    public class Animal
    {
        //Fields
        public string Name;
        public int BirthYear;
        private int Score;
        private int BeautyPoint;
        private int BehaviourPoint;
        public int AgeLimit;
        public int ActualYear;
        private int Age;

        //Constructor
        public Animal(string name, int birthYear, int score, int beautyPoint, int behaviourPoint, int age){
            this.Name = name;
            this.BirthYear = birthYear;
            this.BeautyPoint = beautyPoint;
            this.BehaviourPoint = behaviourPoint;
            this.Score = score;
            this.Age = age;
        }
        //methods
        public int Scoring(){
            Score = AgeLimit*BehaviourPoint + (AgeLimit - AAge())*BeautyPoint;
            return Score;
        }
        public int AAge(){
            Age = ActualYear - BirthYear;
            return Age;
        }
        //Properties (getters and setters)
        public string Name_{
            get{ return Name; }
            set{ Name = value; }
        }
        public int BirthYear_{
            get{ return BirthYear; }
            set{ BirthYear = value; }
        }
        public int Score_{
            get { return Score; }
            set { Score = value; }
        }
        public int BeautyPoint_{
            get { return BeautyPoint; }
            set { BeautyPoint = value; }
        }
        public int BehaviourPoint_{
            get { return BehaviourPoint; }
            set { BehaviourPoint = value; }
        }
        public int AgeLimit_{
            get { return AgeLimit; }
            set { AgeLimit = value; }
        }
        public int ActualYear_{
            get{ return ActualYear; }
            set{ ActualYear = value; }
        }
    }
}