function dockTwins() {

    // dock window 1 to the left using half of the workspace
    App.Desktop.getWindows()[0].setLayoutProperties({ left: 0, right: "50%", top: 0, bottom: 0 });

    // dock window 2 to the right using half of the workspace
    App.Desktop.getWindows()[1].setLayoutProperties({ left: "50%", right: 0, top: 0, bottom: 0 });
}