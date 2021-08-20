using FurnitureApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FurnitureApp
{
    public interface IFurnitureFactory
    {
          IChair CreateChair();
          ISofa CreateSofa();

    }
}
