using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC
{
    internal interface IViewController
    {
        object M(object model);
    }

    internal interface IModelController
    {
        void V();
    }

    internal interface IModel
    {
        object M(object model);

        void SetAdapter(IModelController controller);
    }

    internal interface IView
    {
        void V();

        void SetAdapter(IViewController controller);
    }

    //Factory design pattern
    internal delegate IModel ModelFactory();

    internal delegate IView ViewFactory();

    internal class Model : IModel
    {
        private IModelController Controller;

        public object M(object model)
        {
            return "*" + (string)model + "*";
        }

        public void SetAdapter(IModelController controller)
        {
            Controller = controller;
        }
    }

    internal class View : IView
    {
        private IViewController Controller;

        public void SetAdapter(IViewController controller)
        {
            Controller = controller;
        }

        public void V()
        {
            Console.WriteLine("Iveskite zodi");
            var data = Console.ReadLine();
            Console.WriteLine((string)Controller.M(data));
        }
    }

    internal class Controller : IModelController, IViewController
    {
        private IModel Modelis;
        private IView View;

        public Controller(ModelFactory m, ViewFactory v)
        {
            Modelis = m();
            View = v();
            Modelis.SetAdapter(this);
            View.SetAdapter(this);
        }

        public object M(object model)
        {
            return Modelis.M(model);
        }

        public void V()
        {
            View.V();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Controller controller = new Controller(ModelFactory, ViewFactory);
            controller.V();
        }

        private static IView ViewFactory()
        {
            return new View();
        }

        private static IModel ModelFactory()
        {
            return new Model();
        }
    }
}