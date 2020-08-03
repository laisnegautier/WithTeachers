'use strict';

const configuration = { 'iceServers': [{ 'urls': 'stun:stun.l.google.com:19302' }] }
const peerConnection = new RTCPeerConnection(configuration);


//0.
window.attachHandlers = () => {
    peerConnection.addEventListener('onicecandidate', event => {
        console.log("putin");
        console.log("putin");
        console.log("putin");
        console.log("putin");
        if (event.candidate) {
            console.log("putinas");
            //return JSON.stringify('new-ice-candidate : ' + event.candidate);
            //signalingChannel.send({ 'new-ice-candidate': event.candidate });
            //DotNet.invokeMethodAsync('OnlineEducation', "IceCandidateTrigger", JSON.stringify(event.candidate));
        }
    });

    //peerConnection.onicecandidate = (event) => {
    //    if (event.candidate) {
    //        sendCandidateToRemotePeer(event.candidate)
    //    } else {
    //        /* there are no more candidates coming during this negotiation */
    //    }
    //}
};

//1. Initializing RTCconfiguration
//2. OnReceivingOffer
//3. OnReceivingAnswer
async function makeCall() {
    const offer = await peerConnection.createOffer();
    await peerConnection.setLocalDescription(offer);

    return JSON.stringify(offer);
}

async function onReceivingOffer(offer) {
    offer = JSON.parse(offer); //return to object shape

    const remoteDesc = new RTCSessionDescription(offer);
    peerConnection.setRemoteDescription(remoteDesc);

    const answer = await peerConnection.createAnswer();
    await peerConnection.setLocalDescription(answer);
    console.log(peerConnection);

    console.log("putink");

    //if (peerConnection.onicecandidate) {
    //    try {
    //        await peerConnection.addIceCandidate(peerConnection.iceCandidate);
    //    } catch (e) {
    //        console.error('Error adding received ice candidate', e);
    //    }
    //}

    return JSON.stringify(answer);
}

async function onReceivingAnswer(answer) {
    answer = JSON.parse(answer);

    const remoteDesc = new RTCSessionDescription(answer);
    await peerConnection.setRemoteDescription(remoteDesc);

    console.log("putink2");
    console.log(peerConnection);

}

//ICE Candidates