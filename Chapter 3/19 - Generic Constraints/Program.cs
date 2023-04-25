
/*
CLASS CONSTRAINT
DataStoreReferenceTypes<string> store = new DataStoreReferenceTypes<string>(); // valid
DataStoreReferenceTypes<MyClass> store = new DataStoreReferenceTypes<MyClass>(); // valid
DataStoreReferenceTypes<IMyInterface> store = new DataStoreReferenceTypes<IMyInterface>(); // valid
DataStoreReferenceTypes<IEnumerable> store = new DataStoreReferenceTypes<IMyInterface>(); // valid
DataStoreReferenceTypes<ArrayList> store = new DataStoreReferenceTypes<ArrayList>(); // valid
//DataStoreReferenceTypes<int> store = new DataStoreReferenceTypes<int>(); // compile-time error 
*/

/*
NON-NULLABLE VALUE TYPE CONSTRAINT
DataStoreValueTypes<int> store = new DataStoreValueTypes<int>(); // valid
DataStoreValueTypes<char> store = new DataStoreValueTypes<char>(); // valid
DataStoreValueTypes<MyStruct> store = new DataStoreValueTypes<MyStruct>(); // valid
//DataStoreValueTypes<string> store = new DataStoreValueTypes<string>(); // compile-time error 
//DataStoreValueTypes<IMyInterface> store = new DataStoreValueTypes<IMyInterface>(); // compile-time error 
//DataStoreValueTypes<ArrayList> store = new DataStoreValueTypes<ArrayList>(); // compile-time error 
*/

class DataStoreReferenceTypes<T> where T : class
// Will accept only reference types.
{
    public T Data { get; set; }
}

class DataStoreValueTypes<T> where T : struct
// Will accept only non-nullable value types
{
    public T Data { get; set; }
}
