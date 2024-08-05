// See https://aka.ms/new-console-template for more information
/* The application classifies the room as small (up to and including 250 square feet),
 * medium (more than 250 but less than 650 square feet), or large (650 square feet or more).

*/
Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");
Console.WriteLine("Enter Length:");
double rLength = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Width:");
double rWidth = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Height:");
double rHeight = Convert.ToDouble(Console.ReadLine());
double area;
area = rLength * rWidth;  //Calculating area
Console.WriteLine($"Area : {area} Sq.units");
double perimeter;
perimeter = 2 * (rLength + rWidth); // Calculating perimeter
Console.WriteLine($"Perimeter : {perimeter} units");
if (area<=250)
{
    Console.WriteLine($"the room as small with {area} Sq.units ");
}
else if(area>250 && area<= 650)
{
    Console.WriteLine($"the room as medium with {area} Sq.units ");
}
else if (area > 650)
{
    Console.WriteLine($"the room as large with {area} Sq.units ");
}
double volume;
volume = rLength * rWidth * rHeight;
Console.WriteLine($"Volume : {volume} cubic units");
double sArea;//A=2(wl+hl+hw)
sArea = 2 * (rWidth * rLength + rHeight * rLength + rHeight * rWidth);
Console.WriteLine($"Surface Area : {sArea} Sq.units");
Console.WriteLine("Thank you for using the Room Detail Generator!");