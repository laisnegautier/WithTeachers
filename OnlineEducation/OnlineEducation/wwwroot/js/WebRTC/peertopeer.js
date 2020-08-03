'use strict';

//0.
window.webRTC_init = () => {
    const makeCallButton = document.querySelector('#makeCallButton');

    makeCallButton.onclick = makeCall;

    //localVideo.addEventListener('loadedmetadata', function () {
    //    console.log(`Local video videoWidth: ${this.videoWidth}px,  videoHeight: ${this.videoHeight}px`);
    //});

    //remoteVideo.addEventListener('loadedmetadata', function () {
    //    console.log(`Remote video videoWidth: ${this.videoWidth}px,  videoHeight: ${this.videoHeight}px`);
    //});
};

//1. Initializing RTCPeerConnection
async function makeCall() {
    const configuration = { 'iceServers': [{ 'urls': 'stun:stun.l.google.com:19302' }] }
    const peerConnection = new RTCPeerConnection(configuration);

    //signalingChannel.addEventListener('message', async message => {
    //    if (message.answer) {
    //        const remoteDesc = new RTCSessionDescription(message.answer);
    //        await peerConnection.setRemoteDescription(remoteDesc);
    //    }
    //});

    const offer = await peerConnection.createOffer();
    await peerConnection.setLocalDescription(offer);

    //console.log("offer: " + offer);
    return JSON.stringify(offer);

    //signalingChannel.send({ 'offer': offer });
}
