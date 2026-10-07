namespace oop_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions
            //Q1  Object Copying

            //a) What happens when you assign one object variable to another object variable?
            //only the reference is copied, not the object itself.

            //b) Does assigning one object to another create a new object? Explain.
            //no , both variables end up pointing to the same object on the heap, so no new object is allocated.

            //c) What is the difference between copying an object and copying its reference?
            //copying an object creates a new instance of the object with the same values,
            //while copying a reference only copies the memory address of the object, so both variables point to the same object.


            //Q2  Shallow Copy vs Deep Copy

            //a) What is a Shallow Copy?
            //shallow copy creates a new object that is a copy of the original object,
            //but it only copies the references to the objects that are contained within the original object.

            //b) What is a Deep Copy?
            //Deep Copy creates completely new object and recursively copies all fields,
            //So the original and the copy are fully independent , changing one does not affect the other.

            //c) What happens to reference-type members when a Shallow Copy is created?
            //reference-type members are not copied. Only their references are copied.
            //So both the original and the shallow copy will point to the same reference-type members.

            //d) What happens to reference-type members when a Deep Copy is created?
            //reference-type members are also copied,
            //so the original and the deep copy will have their own separate copies of the reference-type members.

            //e) Give one situation where Deep Copy would be safer than Shallow Copy.
            //Deep Copy would be safer when you want to create a copy of an object that contains mutable reference-type members,
            #endregion
        }
    }
}
