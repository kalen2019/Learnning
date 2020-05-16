var a = [[1,2],[3,4]];
var b = [[1,1],[1,1]];
function add(a,b)
{
    var add = [[],[]];
    for(i=0;i<2;i++)
    {
        for(j=0;j<2;j++)
        {   
        
            add[i][j] = a[i][j] + b[i][j]; 
        }
    }
    return add;
}
console.log("add(",a,",",b,") =>",add(a,b));