import './Category.css'
function Category(){
    var category = {
        name : "appoinments",
        color:"yellow"
    }
    return(
        <div className="category">
            <h1>Category</h1>
            <br/>
            Category name : {category.name}
            <br/>
            Category color : {category.color}
        </div>
    );
}

export default Category;