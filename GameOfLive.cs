public class GameOfLive{
    Cell[,] grid;

    public GameOfLive(int nbLignes, int nbColonnes){
        this.grid = new Cell[nbLignes,nbColonnes];
        for (int i = 0; i < nbLignes; i++){
            for (int j = 0; j < nbColonnes; j++){
                this.grid[i,j] = new Cell();
            }
        }
    }

    private void memorize(){
        for (int i = 0; i < this.grid.Length; i++){
            for (int j = 0; j < this.grid.GetLength(1); j++){
                this.grid[i,j].memorize();
            }
        }
    }

    public void next(){
        this.memorize();
        for (int i = 0; i < this.grid.Length; i++){
            for (int j = 0; j < this.grid.GetLength(1); j++){
                this.grid[i,j].next(nbNearby(i, j));
            }
        }
    }

    private int nbNearby(int i, int j){
        int nbNearby = 0;
        for (int k = i - 1; k <= i + 1; k++){
            for (int l = j - 1; l <= j + 1; l++){
                if (k == i && l == j){
                    continue;
                }
                if (k < 0 || k >= this.grid.Length){
                    continue;
                }
                if (l < 0 || l >= this.grid.GetLength(1)){
                    continue;
                }
                if (this.grid[k,l].wasAlive){
                    nbNearby++;
                }
            }
        }
        return nbNearby;
    }
/*
    public override string toString{
        string s = "";
        foreach (Cell[] line in grids){
            foreach (Cell cell in line){
                s += cell.isAlive.toString();
            }
            s += "\n";
        }
    }*/
}