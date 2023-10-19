namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri[] GeometriObjects= new Geometri[5];
            {

               GeometriObjects[0] = new Cirkel();
               GeometriObjects[1] = new Fyrkant();
               GeometriObjects[2] = new Rektangel();
               GeometriObjects[3] = new Parallellogram();
               GeometriObjects[4] = new Ellips(); 
                

            }

            foreach (var Objects in GeometriObjects)
            {

              Console.WriteLine(Objects.Output());

            }


        }

    }
}