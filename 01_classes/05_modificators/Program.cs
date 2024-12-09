
// Модификаторы доступа к членам типа
// private
// public
// protected
// private protected                    // внутри сборки: protected;    снаружи сборки: private
// internal                             // внутри сборки: public;       снаружи сборки: private
// protected internal                   // внутри сборки: public;       снаружи сборки: protected

// Модификаторы для типа в целом
// internal
// public
// file


using ModificatorsLib;

Class1 a = new Class1();
// a.privateField = 34;        // ERRROR
a.publicField = 34;
// a.protectedField = 45;          // ERROR
// a.privateProtectedField = 12;       // ERROR
// a.internalField = 78;                // ERROR
// a.protectedInternalField = 67;          // ERROR


class Class2: Class1
{
    public void Test()
    {
        protectedField = 56;
        protectedInternalField = 140;
    }
}










