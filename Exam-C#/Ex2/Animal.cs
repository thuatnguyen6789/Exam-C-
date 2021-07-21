using System;

namespace AnimalInfor
{
    public class Animal
    {
        public string name = "";
        public double weight = 0;
        
        public virtual  void Show()
        {
            string info = "Name: " + name + ", " + "Weight: " + weight;
            Console.WriteLine(info);
        }

        public virtual void SetMe(string m_name, double m_weight)
        {
            name = m_name;
            weight = m_weight;
        }
    }
}