// verifica progressione aritmetica dati 3 numeri

Console.WriteLine("Verifichiamo se i seguenti numeri costituiscono una progressione artimetica.\nInserisci il primo numero");

// converte il primo input in un intero 
 
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserisci il secondo numero");

// converte il secondo input in un intero  

int num2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Inserisci il terzo numero");

// converte il terzo input in un intero  

int num3 = Convert.ToInt32(Console.ReadLine());

// inizializza variabile differenza1 con valore dato dalla differenza dei primi 2 numeri

int differenza1 = num2 - num1;

// inizializza variabile differenza1 con valore dato dalla differenza del secondo e terzo numero

int differenza2 = num3 - num2;

// se la differenza tra i inumeri inseriti è costante allora si tratta di una progressione aritmetica

if(differenza1 == differenza2){
    Console.WriteLine($"Abbiamo una progressione aritmetica.La differenza tra i numeri indicati è costante sempre {differenza1}");

}else{
    Console.WriteLine("Questa non è una progressione aritmetica");  
}