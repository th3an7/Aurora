// START METADATA
// NAME: Aurora GSI
// AUTHOR: th3ant
// DESCRIPTION: Get RGB effects in Aurora
// END METADATA


/// <reference path="../globals.d.ts" />

class AuroraSpotify {
    
    constructor() {
        this.json = {
            "provider": {
                "name": "spotify",
                "appid": -1
            },
            "player":{
                "duration": -1,
                "progress": -1,
                "mute": false,
                "repeat": -1,
                "shuffle": false,
                "heart": false,
                "volume": -1,
                "playing": false
            },
            "colors": {
                "desaturated": "",
                "light_vibrant": "",
                "prominent": "",
                "vibrant": "",
                "vibrant_non_alarming": ""
            }
        }
    }

    update() {
        this.updatetimer = setInterval(() => {
        var self = this;

        self.json.player.duration = Spicetify.Player.getDuration();
        self.json.player.progress = Spicetify.Player.getProgress();
        self.json.player.mute = Spicetify.Player.getMute();
        self.json.player.repeat = Spicetify.Player.getRepeat();
        self.json.player.shuffle = Spicetify.Player.getShuffle();
        self.json.player.heart = Spicetify.Player.getHeart();
        self.json.player.volume = Math.round(Spicetify.Player.getVolume()*100);
        self.json.player.playing = Spicetify.Player.isPlaying();

        //ADD COLORS LATER
        Spicetify.getAblumArtColors(Spicetify.Player.data.track.metadata.album_uri)
        .then((colors) => {
            self.json.colors.desaturated = colors.DESATURATED;
            self.json.colors.light_vibrant = colors.LIGHT_VIBRANT;
            self.json.colors.prominent = colors.PROMINENT;
            self.json.colors.vibrant = colors.VIBRANT;
            self.json.colors.vibrant_non_alarming = colors.VIBRANT_NON_ALARMING;
        })

        this.sendJsonToAurora (this.json);

        }, 500);
    }

    async sendJsonToAurora(json) {
        fetch('http://localhost:9088/', {
            method: 'POST',
            body: JSON.stringify(json),
            mode:'no-cors',
            headers:{
                'Content-Type': 'application/json'
            }
        })
		.catch (error => {
			return undefined;
		});
    }
}

let run = new AuroraSpotify();
run.update();