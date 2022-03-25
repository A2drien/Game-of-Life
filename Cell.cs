public class Cell{
    public bool isAlive{get{return this.isAlive;} set{this.isAlive = value;}}
    public bool wasAlive{get{return this.wasAlive;} set{this.wasAlive = value;}}

    public Cell(){
        setAlive(false);
    }

    private void setAlive(bool isAlive){
        this.isAlive = isAlive;
    }

    public void next(int nbVoisins){
        if ((nbVoisins == 3) || (nbVoisins == 2 && isAlive)){
            this.isAlive = true;
        }

        else{
            this.isAlive = false;
        }
    }

    public void memorize(){
        this.wasAlive = this.isAlive;
    }

    public string toString(){
        return this.isAlive ? "X" : " ";
    }
}