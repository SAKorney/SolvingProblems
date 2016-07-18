#include <iostream>
#include "abstractfactory.h"
#include "abstractproduct.h"

int main(int argc, char **argv)
{
    AbstractFactory *factory;
    AbstractProduct *product;

    int input;

    std::cout<<"Input type factory [1-2]: ";
    std::cin>>input;
    std::cout<<std::endl;

    (input==1) ? factory = new ConcreteFactoryOne() : new ConcreteFactoryTwo();

    product = factory->CreateProduct();
    product->GetName();
    
    delete product;
    delete factory;

    return 0;
}
