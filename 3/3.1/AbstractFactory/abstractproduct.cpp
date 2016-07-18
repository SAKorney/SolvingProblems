#include "abstractproduct.h"
#include <iostream>

AbstractProduct::AbstractProduct()
{
    std::cout << "AbstractProduct constructor" << std::endl;
}

AbstractProduct::~AbstractProduct()
{
    std ::cout << "AbstractProduct destructor" << std::endl;
}
void AbstractProduct::GetName()
{
    std::cout << "Name: AbstractProduct" << std::endl;
}

void ConcreteProductAOne::GetName()
{
    std::cout << "Name: ConcreteProductAOne" << std::endl;
}

void ConcreteProductATwo::GetName()
{
    std::cout << "Name: ConcreteProductATwo" << std::endl;
}

ConcreteProductAOne::ConcreteProductAOne()
{
    std::cout << "Constructor ConcreteProductAOne" << std::endl;
}

ConcreteProductATwo::ConcreteProductATwo()
{
    std::cout << "Constructor ConcreteProductATwo" << std::endl;
}

ConcreteProductAOne::~ConcreteProductAOne()
{
    std::cout << "Destructor ConcreteProductAOne" << std::endl;
}

ConcreteProductATwo::~ConcreteProductATwo()
{
    std::cout << "Destructor ConcreteProductATwo" << std::endl;
}
