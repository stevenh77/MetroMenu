function onSourceDownloadProgressChanged(sender, eventArgs) {
    var val = Math.round((eventArgs.progress * 1000)) / 10;
    //sender.findName("progressText").Text = String(Math.round(val));

    if (val <= 25) {
        sender.findName("LoadingMask1").ScaleX = val / 25;
    }
    if (val > 25 && val <= 50) {
        sender.findName("LoadingMask1").ScaleX = 1;
        sender.findName("LoadingMask2").ScaleX = val / 50;
    }
    if (val > 50 && val <= 75) {
        sender.findName("LoadingMask1").ScaleX = 1;
        sender.findName("LoadingMask2").ScaleX = 1;
        sender.findName("LoadingMask3").ScaleX = val / 75;
    }
    if (val > 75 && val <= 100) {
        sender.findName("LoadingMask1").ScaleX = 1;
        sender.findName("LoadingMask2").ScaleX = 1;
        sender.findName("LoadingMask3").ScaleX = 1;
        sender.findName("LoadingMask4").ScaleX = val / 100;
    }
}