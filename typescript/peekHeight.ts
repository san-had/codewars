export function peekHeight(mountain: string[][]) {
    let pattern: string = " ";
    let nextPattern: string;
    let count: number;
    let peakHeight: number = 0;

    let index: number = 0;
    do {
        if (index != 0) {
            pattern = index.toString();
        }
        nextPattern = (index + 1).toString();
        count = putChar(mountain, pattern, nextPattern); 
        if (count != 0) {
            index++;
        }           
    } while(count != 0);

    peakHeight = index;

    displayMountain(mountain);

    return peakHeight;
  }

  function putChar(mountain: string[][], boundaryChar: string, newChar: string ) : number {

    let rowMax = mountain.length;  

    let count: number = 0;

    for (let i = 0; i < rowMax; i++)
    {
        let columnMax = mountain[i].length;
        for (let j = 0; j < columnMax; j++)
        {
            if (mountain[i][j] == '^')
            {
                if (i == 0 || j == 0 || i == rowMax - 1 || j == columnMax - 1)
                {
                    mountain[i][j] = newChar;
                    count++;
                    continue;
                }
                
                let newCharNeeded: boolean = mountain[i - 1][j] === boundaryChar || mountain[i][j - 1] === boundaryChar ||
                mountain[i + 1][j] === boundaryChar || mountain[i][j + 1] === boundaryChar;
                                
                if (newCharNeeded)
                {
                    mountain[i][j] = newChar;
                    count++;
                }
            }
        }
    }
    return count;      
  }

  function displayMountain(mountain) {

    mountain.forEach(row => {
        console.log(row.join(''));
        
    });    
  }