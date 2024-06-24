// See https://aka.ms/new-console-template for more information

//int fineGioco = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Indica un numero da 1 a 6");

int numeroScelto = Convert.ToInt32(Console.ReadLine());
if(numeroScelto > 6 || numeroScelto < 1){
    Console.WriteLine("Il numero inserito non è valido prega indica un numero da 1 a 6");
    
}else{

 Random rnd = new Random();

 int estrazione = rnd.Next(1,7);

Console.WriteLine($"Il numero estratto è {estrazione}");


if(numeroScelto == estrazione){
   Console.WriteLine($"Complimenti hai indovinato il numero estratto è {numeroScelto}");
   
}else{
    Console.WriteLine($"Spiacente,ritenta, sarai più fortunato");

}

}
