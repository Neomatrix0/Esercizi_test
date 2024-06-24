//initialization of the variable to the current year
int currentYear = DateTime.Now.Year;

//ask to type your name
Console.WriteLine("Hi there,please type your name:");

// read input name
string? name = Console.ReadLine();

// ask to type your age 

Console.WriteLine("please type your age:");

// convert string input in integer input

int age =  Convert.ToInt32(Console.ReadLine());

// formula to get date of birth as test
int datebirth = currentYear - age;

// print name, age and birthday

Console.WriteLine($"Hi {name},You are {age} years old.You were born in {datebirth}");


static int factorial(int num){
    if(num == 1){
        return (1);
    }else{
        return(num* factorial(num -1));
    }

}




factorial(4);

