namespace knightmoves;

public class Party {
    public Person[] Guests = new Person[] {
        new Person("Jimmy", "Scott"),
        new Person("Bobby", "Jones"),
        new Person("Sarah", "Smith")
    };

    public class Person {
        public string firstName;
        public string lastName;

        public Person(string firstName, string lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
    

//should define a class named Person that takes two parameters: firstName and lastName when it's created
//should create a class-level variable array named Guests that contains three instances of the Person class
