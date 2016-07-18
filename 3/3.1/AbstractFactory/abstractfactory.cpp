#include "abstractfactory.h"
#include <string>
#include <iostream>

AbstractFactory::AbstractFactory()
{
    std::cout << "AbstractFactory constructor" << std::endl;
}

ConcreteFactoryOne::ConcreteFactoryOne()
{
    std::cout << "ConcreteFactoryOne constructor" << std::endl;
}

ConcreteFactoryTwo::ConcreteFactoryTwo()
{
    std::cout << "ConcreteFactoryTwo constructor" << std::endl;
}

AbstractFactory::~AbstractFactory()
{
    std::cout << "Destructor AbstractFactory" << std::endl;
}

ConcreteFactoryOne::~ConcreteFactoryOne()
{
    std::cout << "Destructor ConcreteFactoryOne" << std::endl;
}

ConcreteFactoryTwo::~ConcreteFactoryTwo()
{
   std::cout << "Destructor ConcreteFactoryTwo" << std::endl;
}

AbstractProduct* ConcreteFactoryOne::CreateProduct() const
{
   return new ConcreteProductAOne();
}

AbstractProduct* ConcreteFactoryTwo::CreateProduct() const
{
   return new ConcreteProductATwo();
}

AbstractProduct* AbstractFactory::CreateProduct() const
{

}

