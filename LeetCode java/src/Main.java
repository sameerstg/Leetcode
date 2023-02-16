

public class Main {
    int a;
    public static void main(String[] args) {
        print(a);
    }
}
class Student{
    private int id;
    boolean present;
    float marks;
    long phoneNumber;
    public Student(int idDo,float pichleMarks,long phoneNumber){
        setId(idDo);
        marks =pichleMarks;
        this.phoneNumber = phoneNumber;
    }

    public void setId(int id) {
        this.id = id;
    }
    public int GetId(){
        return id;
    }

}
class Car{
    int seater;
    int refistrationNumber;
    String manufacturerName;
    String carName;


    Tire tire[];
    int windsheild ;
    int engine;
    int door;
    int seat;
    int silencer;



}
class Tire{
    int pli;
    float width;
    float height;
    Date useStartingDate;
    void Rotate(){
        System.out.println("Tire Rotating");
    }
    void Stop(){
        System.out.println("Tire Stopped");
    }
}
abstract class Father{
void Poop(){

}
}
class  Child extends Father{

}