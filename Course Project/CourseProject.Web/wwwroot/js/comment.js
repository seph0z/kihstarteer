"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message, time, userImg) {
    var encodedMsg = `
            <div id="brd1">
                     <div class="row">
                        <div class="col-1">
                            <img src="` + userImg + `" alt="" style="width: 100%; border-radius: 50%;">
                        </div>
                        <div class="col-11">
                            <div id="nameComment">`
                                + user +
                            `</div>
                        <div style="font-weight: lighter; ">`
        + time +
                        `</div>
                        </div>
                        <div id="textComment">`
                            + message +
                        `</div>
                    </div>
                </div>`;  
    var parentElement = document.getElementById('messagesList');
    var theFirstChild = parentElement.firstChild;
    var newElement = document.createElement("div");
    newElement.innerHTML = encodedMsg;
    parentElement.insertBefore(newElement, theFirstChild);
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    var projectId = document.getElementById("projectId").value;
    var userImage = document.getElementById("commentImage").value;
    var userId = document.getElementById("userId").value;
    connection.invoke("SendMessage", user, message, projectId, userImage, userId).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();

    document.getElementById("messageInput").value = "";
    document.getElementById("messageInput").focus();
});

document.getElementById("messageInput").addEventListener("keyup", function (event) {
    event.preventDefault();
    if (event.keyCode === 13) {
        document.getElementById("sendButton").click();
    }
});