var a = [[1,2,3],[3,2,1]];
function transpose(a)
{
    var transpose = [[,],[,],[,]];
    
    for(i=0;i<a.length;i++)
    {
        for(j=0;j<a[i].length;j++)
        {
            transpose[j][i] = a[i][j];
        }
    }
    return transpose;
}
console.log("transpose(",a,") =>",transpose(a));