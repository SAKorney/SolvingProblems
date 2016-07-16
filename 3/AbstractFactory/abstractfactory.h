#ifndef ABSTRACTFACTORY_H
#define ABSTRACTFACTORY_H

#include "abstractproduct.h"

class AbstractFactory {
public:
    AbstractFactory();
    virtual AbstractProduct* CreateProduct() const;
    virtual ~AbstractFactory();
};

class ConcreteFactoryOne: public AbstractFactory{
public:
    ConcreteFactoryOne();
    AbstractProduct* CreateProduct() const;
    virtual ~ConcreteFactoryOne();
};

class ConcreteFactoryTwo: public AbstractFactory{
public:
    ConcreteFactoryTwo();
    AbstractProduct* CreateProduct() const;
    virtual ~ConcreteFactoryTwo();
};

#endif // ABSTRACTFACTORY_H
