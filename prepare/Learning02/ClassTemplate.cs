/*  A class is a unique data structure that allows for customization. 
    It is a blueprint of an object( real world entity such as a character
    in a game).

    KEYWORDS
    Class:  Blueprint for an object.
    Class Object( Instance ): The physical created copy of a class. The variable name.
    Class Type: Refering to the class name which is its unique type. Similar to int, string or bool.
    Instantiate: The process of creating a class object.
    Attributes(Fields):  Class variables.
    Method(Behaviours): Class functions used to support logic needed for the class.
    Constructor: A special method that is used to set up the class and only called once
        (CLASS TYPE) (OBJECT NAME) = new ( CONSTRUCTOR( PARAMETERS ) )
        ClassT       myClassT      = new ClassT();
    State: Refering to the current status and values of all attributes.

*/
//(ACCESS TYPE) class (NAME) {}
public class ClassT
{
    //ATTRIBUTES
    //(ACCESS TYPE) (TYPE) (Name)
    public string name;
    private int x;
    private bool myBool;
    private List<string> myList = new();

    //CONSTRUCTORS
    // By defualt a class automatically comes weith the empty constructor until a explicit constructor is defined.
    //(ACCESS TYPE) (NAME *Same as class)(PARAMETERS){}
    public ClassT(string name)
    {
        this.name = name;
    }
    //METHODS
    // Logic needed to support the class functionality
    
}