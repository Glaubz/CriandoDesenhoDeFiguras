using System;

namespace Ex2.Entities
{
    public class Square : GeometricFigure
    {
        public Square(){
        }

        public Square(int side){
            Side = side;
            Draw = new char[Side,Side];
            setDraw(); //Ao construir um objeto do tipo Quadrado já é contruído o desenho da figura After building a object of squere type, is builded the figure design
        }

        public override void setDraw(){
            for(int i=0; i<Side; i++){
                Draw[0,i] = '*';
                Draw[i,0] = '*';
            }
            for(int i=0, j=Side-1; i<Side; i++){
                Draw[j,i] = '*';
                Draw[i,j] = '*';
            }
        }

        public override void printDraw(){
            for(int i=0; i<Side; i++){
                for(int j=0; j<Side; j++){
                    if(Draw[i,j] == '\0'){ //Verify the position to see if is a default position of char, if is, is alocked a space to not deform the draw
                        Console.Write("  ");
                    }
                    else{
                        Console.Write(Draw[i,j] + " ");
                    }
                }
                Console.WriteLine(); //jump line
            }
        }

    }
}