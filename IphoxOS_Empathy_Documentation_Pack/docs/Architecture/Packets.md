# Packets

Packets are the language used by the organs of IphoxOS.

Organs should not control each other directly.
They should exchange meaning through packets.

## Observation Packet

Produced by Eyes.

```json
{
  "mode": "gameplay",
  "scene": "Gameplay",
  "event_running": false,
  "chat_activity": "quiet",
  "creator_speaking": true,
  "stream_duration_seconds": 1240
}
```

## Analysis Packet

Produced by Brain.

```json
{
  "environment": "stable",
  "live_energy": "low",
  "audience_activity": "quiet",
  "creator_focus": "high"
}
```

## Empathy Packet

Produced by Empathy.

```json
{
  "creator_state": "focused",
  "community_state": "quiet",
  "relationship_state": "aligned",
  "confidence": "medium"
}
```

## Emotion Packet

Produced by Heart.

```json
{
  "mood": "curious",
  "energy": "stable",
  "concern": "low"
}
```

## Decision Packet

Produced by Director.

```json
{
  "action": "observe",
  "priority": 0,
  "reason": "The stream is stable and no support is needed."
}
```

## Packet Principle

A packet must describe meaning, not implementation.

Bad:

```json
{ "set_spotify_volume": -18 }
```

Good:

```json
{ "audio_intent": "make_creator_clearer" }
```
