//store elements from HTML 
const todoForm = document.getElementById('todo-form');
const todoInput = document.getElementById('todo-input');
const todoList = document.getElementById('todo-list');

//Event for when user adds a new task
//  1. prevent default form submission behavior, which refreshes the page
//  2. check if input field is empty. If yes, alert user.
//  3. add the new task (addTask function)
//  4. clear the input field after adding the task.

todoForm.addEventListener('submit', function(event) {
    event.preventDefault();
    const newTask = todoInput.value;
  
    if (newTask === '') {
        alert('Please enter a task!');
        return;
    }
    
    addTask(newTask); //add the new task
    
    todoInput.value = ''; //clear the input field after adding a task
});

//function to create and display a new task in the list
//   1. create new li element for the task
//   2. set its text content to the task passed to the function
//   3. append the new list item to todo-list element
//   4. create a span element to hold the text for the task
//   5. add checkbox to each task to mark it as complete
//   6. delete button to remove tasks
//   7. edit button and appending to each listitem
function addTask(task) {
    const listItem = document.createElement('li');
    const taskText = document.createElement('span');
    taskText.textContent = task;
    listItem.appendChild(taskText);
    
    const checkBox = document.createElement("input");
    checkBox.setAttribute('type', 'checkbox');   
    listItem.appendChild(checkBox);


    const deleteButton = document.createElement('button');
    deleteButton.textContent = 'Delete';
    listItem.appendChild(deleteButton);

    todoList.appendChild(listItem);

    //add event listener to checkbox - use the change event to toggle the text decoration of the task
    checkBox.addEventListener("change", function() {
        if (this.checked) {
            taskText.style.textDecoration = 'line-through';                     
        } else {
            taskText.style.textDecoration = 'none';
        }                
    });

    //add event listener to delete button - remove task from list when the button is clicked
    deleteButton.addEventListener('click', function() {
        todoList.removeChild(listItem);
    });

}  
//clearTask function to clear the whole to-do list
document.querySelector("#clear-list").addEventListener('click', clearTasks)
function clearTasks() {
    const list = document.getElementById("todo-list")
    while (list.hasChildNodes()) {
        list.removeChild(list.firstChild)
    }
}    

    //add event listener to edit button 
    // if the task is in editing mode - save the edited task and switch back to view mode, 
    //                                  otherwise switch to edit mode by replacing the task text with an input field.
    /*
    editButton.addEventListener('click', function() {
        const isEditing = listItem.classList.contains('editing');
      
        if (isEditing) {
            // Switch back to view mode
            taskText.textContent = this.previousSibling.value; // Assuming the input field is right before the edit button
            listItem.classList.remove('editing');
            editButton.textContent = 'Edit';
        } else {
            // Switch to edit mode
            const input = document.createElement('input');
            input.type = 'text';
            input.value = taskText.textContent;
            //listItem.insertBefore(input, taskText);
            //listItem.removeChild(taskText);
            listItem.classList.add('editing');
            editButton.textContent = 'Save';
        }
      });
    */

