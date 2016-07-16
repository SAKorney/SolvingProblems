#ifndef ABSTRACTPRODUCT_H
#define ABSTRACTPRODUCT_H

class AbstractProduct {
public:
    AbstractProduct();
    virtual ~AbstractProduct();
    virtual void GetName();
};

class ConcreteProductAOne: public AbstractProduct{
public:
    ConcreteProductAOne();
    virtual ~ConcreteProductAOne();
    void GetName();
};

class ConcreteProductATwo: public AbstractProduct{
public:
    ConcreteProductATwo();
    virtual ~ConcreteProductATwo();
    void GetName();
};
#endif // ABSTRACTPRODUCT_H
