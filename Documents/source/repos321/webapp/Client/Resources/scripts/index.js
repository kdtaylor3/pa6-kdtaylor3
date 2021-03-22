function getPosts(){
    const allPostsApiUrl = "https://localhost:5001/api/posts";
    
    fetch(allPostsApiUrl).then(function(response){
        console.log(response);
        return response.json();     
    }).then(function(json){
      let html= "<ul>";
      json.forEach((post)=>{
          html+= "<li>" + post.tweet + "</li>";
      });
      html += "</ul>";
      document.getElementById("posts").innerHTML =html; 
      console.log(json);
    }).catch(function(error){
        console.log(error)
    });
}

function postPost(){
    const postPostsApiUrl = "https://localhost:5001/api/posts";
    const tweet = document.getElementById("tweet").value;
    fetch(postPostsApiUrl, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json'
        },
        body: JSON.stringify({
            tweet: tweet
        })
    })
    .then((response)=> {
        console.log(response);
        getPosts();
    })
}
           
        
        