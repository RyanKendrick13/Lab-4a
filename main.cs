using System;

class MainClass {
  public static void Main (string[] args) {
    double [] celsius=new double [7];
    double [] fahrenheit=new double [7];
    double sum =0;
    double avg =0; 
   
    
    
    
  
    for(int pos =0; pos <celsius.Length;pos++){
      Console.WriteLine("Enter Temperature in Celcius");
       celsius[pos] =Convert.ToDouble(Console.ReadLine());
       fahrenheit[pos]= (celsius[pos]*9/5)+32; 
       
       
     
   
    }
    Console.WriteLine("Temperature in Fahrenheit");
    Array.Reverse(fahrenheit);
    foreach(double type in fahrenheit){
      Console.WriteLine(type);
        sum = sum+type;
      
    } 
    avg =sum/celsius.Length;
    Console.WriteLine("The average temperature in Fahrenheit is " + avg);
  
    
    
     
  }
}